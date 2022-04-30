using System;
using System.IO;
using System.Windows.Forms;

namespace MerisToSQL
{
    public class MeriseSQL
    {
        //vars
        ADO ado = new ADO();
        string raw = "";//this is the raw data 
        string[] tables;
        int tableLength;
        string Query;
        //constructors
        public MeriseSQL() { }
        public MeriseSQL(string rawData,string BName)
        {
            if(rawData.Trim() == "")
            {
                MessageBox.Show("There is no rawdata");
            }
            else
            {
                this.raw = rawData;
                tables = raw.ToLower().Split('\n'); ;
                tableLength = tables.Length;
                BaseName = BName;
                //MessageBox.Show(BaseName);
            }
        }
        //end
        //getters 
        public string[] Tables
        {
            get { return tables; }
        }
        public string RawData
        {
            set { raw = value; }
            get { return raw; }
        }
        public int TablesCount
        {
            get { return tableLength; }
        }
        public string BaseName
        {
            get;
            set;
        }
        //end
        //functions
        public string getTableName(int index)
        {
            return Tables[index].Split('(')[0].Trim().ToLower();
        }
        public string TableNameByColumn(string columnName,string table)
        {
            string tableName = "";
            columnName = columnName.Replace("$", "").Replace("#", "").Replace("!", "");
            for(int i=0;i<tableLength;++i)
            {
                //MessageBox.Show($"{table.Trim().ToLower()} == {getTableName(i)}\n{tableLength}");

                if (table.Trim().ToLower() == getTableName(i))
                    break;
                foreach (string column in getColumns(i))
                {

                    if (column.Replace("$", "").Replace("#", "").Replace("!", "") == columnName.Trim().ToLower())
                    {
                        tableName = getTableName(i);
                        return tableName;
                    }
                    //MessageBox.Show($"{column} == {columnName.Trim().ToLower()}");
                }
            }
            return "1";
        }
        public string[] getColumns(int tableIndex)
        {
            string[] columns = null;
            try
            {
                columns = Tables[tableIndex].Split('(')[1].Replace(" ", "").Replace(")", "").Split(',');
            }
            catch
            {
                MessageBox.Show("please Format The Meris Correctly");
            }
            return columns;
        }
        public string createQuery()
        {
            //creating the base
            Query = $"Create database {BaseName}{Environment.NewLine}use {BaseName}{Environment.NewLine}";
            //looping through the tables
           for(int i = 0; i < TablesCount; ++i)
            {
                Query += $"{Environment.NewLine}create table {getTableName(i)}{Environment.NewLine}({Environment.NewLine}";
                //looping through the columns
                foreach (string column  in getColumns(i))
                {
                    //! for primary key
                    //# foreign key
                    //% date
                    //$ int 
                    //primary keys
                    if (column.Contains("!"))
                    {
                        //regular int column
                        if (column.Contains("$"))
                        {
                            Query += $"\t{column.Replace("!","").Replace("$","")} int not null primary key,{Environment.NewLine}";
                        }
                        //regular string column
                        else
                        {
                            Query += $"\t{column.Replace("!","")} varchar(50) not null primary key,{Environment.NewLine}";
                        }
                    }
                    else if (column.Contains("#"))
                    {
                        //regular int column
                        if (column.Contains("$"))
                        {
                            Query += $"\t{column.Replace("#", "").Replace("$", "")} int not null foriegn key references " +
                             $"{TableNameByColumn(column, getTableName(i))}({column.Replace("#", "").Replace("$","")}),{Environment.NewLine}";
                        }
                        //regular string column
                        else
                        {
                            Query += $"\t{column.Replace("#", "")} varchar(50) not null foriegn key references " +
                             $"{TableNameByColumn(column, getTableName(i))}({column.Replace("#", "")}),{Environment.NewLine}";
                        }
                    }
                    else
                    {
                        //regular int column
                        if (column.Contains("$"))
                        {
                            Query += $"\t{column.Replace("$", "")} int,{Environment.NewLine}";
                        }
                        else if (column.Contains("@"))
                        {
                            Query += $"\t{column.Replace("@", "")} float,{Environment.NewLine}";
                        }
                        //regular date column
                        else if (column.Contains("%"))
                        {
                            Query += $"\t{column.Replace("%", "")} date,{Environment.NewLine}";
                        }
                        //regular string column
                        else
                        {
                            Query += $"\t{column} varchar(30),{Environment.NewLine}";
                         
                        }
                    }
                    ////for ints
                    //if (column.Contains("num")|| column.Contains("id"))
                    //{
                    //    if (column.Contains("#") == true)
                    //    {
                    //        Query += $"\t{column.Replace("#","")} int not null foriegn key references " +
                    //         $"{TableNameByColumn(column.Replace("#", ""), getTableName(i))}({column.Replace("#", "")}),{Environment.NewLine}";
                    //     }
                    //    else
                    //    {
                    //        Query += $"\t{column} int not null primary key,{Environment.NewLine}";
                    //    }
                    //}
                    //else if (column.Contains("nombre") || column.Contains("prix")|| column.Contains("montant"))
                    //{
                    //    Query += $"\t{column} int,{Environment.NewLine}";
                    //}
                    ////for dates
                    //else if(column.Contains("date") == true)
                    //{
                    //    Query += $"\t{column} date,{Environment.NewLine}";
                    //}
                    ////for strings
                    //else if (column.Contains("cin") == true)
                    //{
                    //    if(column.Contains("#") == true)
                    //    {
                    //        Query += $"\t{column.Replace("#","")} varchar(30) not null foriegn key references " +
                    //            $"{TableNameByColumn(column.Replace("#", ""), getTableName(i))}({column.Replace("#","")}),{Environment.NewLine}";
                    //    }
                    //    else
                    //    {
                    //        Query += $"\t{column} varchar(30) not null primary key,{Environment.NewLine}";
                    //    }
                    //}
                    //else if (column.Trim() == "")
                    //{
                    //    continue;
                    //}
                    //else
                    //{
                    //    if (column.Contains("#") == true)
                    //    {
                    //        Query += $"\t{column.Replace("#", "")} varchar(30) not null foriegn key references " +
                    //            $"{TableNameByColumn(column.Replace("#", ""), getTableName(i))}({column.Replace("#", "")}),{Environment.NewLine}";
                    //    }
                    //    else
                    //    {
                    //        Query += $"\t{column} varchar(30),{Environment.NewLine}";
                    //    }

                    //    //MessageBox.Show(Query)
                    //}
                }

                Query  = Query.Remove(Query.Length - 3);
                Query += $"{Environment.NewLine});{Environment.NewLine}";
            }
            
            return Query;
        }
        public void     saveFile(string s)
        {
            StreamWriter sw = new StreamWriter("main.txt");
            sw.Write(s);
            sw.Close();
        }
    }
}

//string[] Tables = merise.Text.ToLower().Split('\n');

//for (int i=0;i<Tables.Length;++i)
//{
//    string[] TableInfo = Tables[0].Split('(');

//    string TableName = TableInfo[0];

//    string[] columns = TableInfo[1].Replace(" ", "").Replace(")", "").Split(',');

//    request = $"create table {TableName}\n(\n";

//    foreach (string column in columns)
//    {
//if (column.Contains("num") == true || column.Contains("id") == true || column.Contains("nombre") == true)
//{
//    request += $"\t{column} int,{Environment.NewLine}";
//    //MessageBox.Show(request);
//}
//else if (column.Contains("date") == true)
//{
//    request += $"\t{column} date,{Environment.NewLine}";
//}
//else
//{
//    request += $"\t{column} varchar(50),{Environment.NewLine}";
//}
//    }
//    request = request.Remove(request.Length - 2);
//    request += Environment.NewLine + ")" + Environment.NewLine;
//}

//finishedres.Text = request;

//StreamWriter sw = new StreamWriter("main.txt");
//sw.Write(request);
//sw.Close();