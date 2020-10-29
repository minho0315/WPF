using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OracleApp
{
    class HrDAO
    {
        private string connectionString;
        private static readonly HrDAO instance = new HrDAO();

        private HrDAO() // 생성자 막기
        {
            connectionString = Properties.Settings.Default.ConString;
        }
        public static HrDAO Instance //instance의 주소를 리턴
        {
            get
            {
                return instance;
            }
        }

        public Employee getEmployee(long empId)
        {
            Employee emp = new Employee();
            string sql = "select * from employees where employee_id = :emp_id";

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString)) // 오라클접속
                {
                    OracleCommand cmd = new OracleCommand(sql, conn)
                    {
                        CommandType = CommandType.Text,
                        BindByName = true
                    };
                    cmd.Parameters.Add(":emp_id", OracleDbType.Long).Value = empId;
                    conn.Open(); //쿼리 날리기

                    using (OracleDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow))
                    {
                        if (reader.Read())
                        {
                            emp.Employee_id = reader.GetInt64(0);
                            emp.First_name = reader.GetString(1);
                            emp.Last_name = reader.GetString(2);
                            emp.Email = reader.GetString(3);
                            emp.Phone_number = reader.GetString(4);
                            emp.Hire_date = reader.GetDateTime(5);
                            emp.Job_id = reader.GetString(6);
                            emp.Salary = reader.GetDouble(7);
                            emp.Commission_pct = reader.IsDBNull(8) ? 0.0 : reader.GetDouble(8);
                            emp.Manger_id = reader.IsDBNull(9) ? 0 : reader.GetInt64(9);
                            emp.Department_id = reader.IsDBNull(10) ? 0 : reader.GetInt32(10);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return emp;
        }

        public ICollection<Employee> getEmployeeList() //직원의 목록을 리턴
        {
            ICollection<Employee> empList = new List<Employee>();
            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.TableDirect;
                    cmd.CommandText = "Employees";
                    conn.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee emp = new Employee();
                            emp.Employee_id = reader.GetInt64(0);
                            emp.First_name = reader.GetString(1);
                            emp.Last_name = reader.GetString(2);
                            emp.Email = reader.GetString(3);
                            emp.Phone_number = reader.GetString(4);
                            emp.Hire_date = reader.GetDateTime(5);
                            emp.Job_id = reader.GetString(6);
                            emp.Salary = reader.GetDouble(7);
                            emp.Commission_pct = reader.IsDBNull(8) ? 0.0 : reader.GetDouble(8);
                            emp.Manger_id = reader.IsDBNull(9) ? 0 : reader.GetInt64(9);
                            emp.Department_id = reader.IsDBNull(10) ? 0 : reader.GetInt32(10);

                            empList.Add(emp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return empList;
        }

        //public ICollection<JobHistory> getHistory(int empId)
        //{
        //    DataTable dt = new DataTable();
        //    ICollection<JobHistory> list = new List<JobHistory>();
        //    try
        //    {
        //        using (OracleConnection conn = new OracleConnection(connectionString))
        //        {
        //            OracleCommand cmd = conn.CreateCommand();
        //            cmd.CommandType = CommandType.StoredProcedure;
        //            cmd.CommandText = "CURSOR_PKG.SP_JOB_HISTORY";
        //            cmd.Parameters.Add(new OracleParameter("IN_EMPLOYEE_ID", OracleDbType.Int32,
        //                empId, ParameterDirection.Input));
        //            cmd.Parameters.Add(new OracleParameter("OUT_CURSOR", OracleDbType.RefCursor,
        //                ParameterDirection.Output));
        //            cmd.Connection = conn;

        //            OracleDataAdapter oracleAdapter = new OracleDataAdapter(cmd);
        //            oracleAdapter.Fill(dt); //데이터베이스에서 나온 결과를 데이터테이블에 넣는다.
        //            if (dt.Rows.Count > 0)
        //            {
        //                foreach (DataRow row in dt.Rows)
        //                {
        //                    JobHistory history = new JobHistory();
        //                    history.Name = row[0].ToString();
        //                    history.job = row[1].ToString();
        //                    DateTime.TryParse(row[2].ToString(), out DateTime startTime);
        //                    history.startDate = startTime;
        //                    DateTime.TryParse(row[3].ToString(), out DateTime endTime);
        //                    history.endDate = endTime;

        //                    list.Add(history);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);

        //    }
        //    return list;
        //}

        public DataSet getInfo()
        {
            DataSet dataSet = new DataSet();

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.TableDirect;
                    cmd.CommandText = "Locations";
                    cmd.Connection = conn;

                    OracleDataAdapter oracleAdapter = new OracleDataAdapter(cmd);
                    oracleAdapter.Fill(dataSet, "LocData");

                    cmd.CommandText = "Jobs";
                    oracleAdapter.Fill(dataSet, "JobData");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dataSet;
        }
    }
}
