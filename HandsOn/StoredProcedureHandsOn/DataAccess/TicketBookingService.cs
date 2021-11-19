using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace StoredProcedureHandsOn.DataAccess
{
    interface ITicketBookingService
    {
        void InsertMovie(Movie movie);
        void DeleteMovie(int id);
        void UpdateMovie(int id, string name); 
        void DeleteTheatre(int id);
        void UpdateTheatre(int id, string name);
        void InsertTheatre(Theatre theatre);
        void DeleteScreen(int id);
        void InsertScreen(Screen screen);
        void UpdateScreen(int id, string name);



    }
    class TicketBookingService : ITicketBookingService
    {
        
        static SqlConnection Connect()
        {
            string con = ConfigurationManager.ConnectionStrings["moviedb"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            return conn;
        }

        #region MovieOperation

        public void InsertMovie(Movie movie)
        {
            SqlConnection conn = Connect();
            try
            {
                conn.Open();
                string query = "sp_InsertMovie";
                SqlCommand sql = new SqlCommand(query, conn);               
                sql.Parameters.AddWithValue("@i", movie.MovieId);
                sql.Parameters.AddWithValue("@n", movie.MovieName);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
         public void DeleteMovie(int id)
        {
            SqlConnection conn = Connect();
            try
            {
                conn.Open();
                string query = "sp_deleteMovieById";
                SqlCommand sql = new SqlCommand(query, conn);               
                sql.Parameters.AddWithValue("@i", id);                
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
         public void UpdateMovie(int id, string name)
        {
            SqlConnection conn = Connect();
            try
            {
                conn.Open();
                string query = "sp_UpdateMovieNameByID";
                SqlCommand sql = new SqlCommand(query, conn);               
                sql.Parameters.AddWithValue("@i", id);
                sql.Parameters.AddWithValue("@n", name);
                
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        #endregion

        #region TheatreOperation


        public void InsertTheatre(Theatre theatre)
        {
            SqlConnection conn = Connect();
            try
            {
                conn.Open();
                
                string query = "sp_InsertTheatre";
                SqlCommand sql = new SqlCommand(query, conn);
                sql.Parameters.AddWithValue("@i", theatre.TheatreId);
                sql.Parameters.AddWithValue("@n", theatre.TheatreName);
              
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }


        public void DeleteTheatre(int id)
        {
            SqlConnection conn = Connect();
            try
            {
                conn.Open();
                string query = "sp_deleteTheatreById";
                SqlCommand sql = new SqlCommand(query, conn);
                sql.Parameters.AddWithValue("@i", id);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public void UpdateTheatre(int id, string name)
        {
            SqlConnection conn = Connect();
            try
            {
                conn.Open();
                string query = "sp_UpdateTheatreNameByID";
                SqlCommand sql = new SqlCommand(query, conn);
                sql.Parameters.AddWithValue("@i", id);
                sql.Parameters.AddWithValue("@n", name);

                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        #endregion



        public void InsertScreen(Screen screen)
        {
            SqlConnection conn = Connect();
            try
            {
                conn.Open();
                string query = "sp_InsertScreen";
                SqlCommand sql = new SqlCommand(query, conn);
                sql.Parameters.AddWithValue("@i", screen.ScreenId);
                sql.Parameters.AddWithValue("@n", screen.ScreenName);
                sql.Parameters.AddWithValue("@ti", screen.theatre.TheatreId);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteScreen(int id)
        {
            SqlConnection conn = Connect();
            try
            {
                conn.Open();
                string query = "sp_deleteScreenById";
                SqlCommand sql = new SqlCommand(query, conn);
                sql.Parameters.AddWithValue("@i", id);
                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        public void UpdateScreen(int id, string name)
        {
            SqlConnection conn = Connect();
            try
            {
                conn.Open();
                string query = "sp_UpdateScreenNameByID";
                SqlCommand sql = new SqlCommand(query, conn);
                sql.Parameters.AddWithValue("@i", id);
                sql.Parameters.AddWithValue("@n", name);

                sql.CommandType = System.Data.CommandType.StoredProcedure;
                sql.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
