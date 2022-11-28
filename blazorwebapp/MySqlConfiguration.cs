namespace blazorwebapp
{
    public class MySqlConfiguration
    {
      
            public MySqlConfiguration(string connectionstring)
            {
                ConnectionString = connectionstring;
            }
            public string ConnectionString { get; set; }
        
    }

 
}
