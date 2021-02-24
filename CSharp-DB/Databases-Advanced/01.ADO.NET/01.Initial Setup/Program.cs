namespace ADONET
{
    using System;
    using System.Data.SqlClient;

    public class Program
    {
        const string SqlConnectionString = "Server=.;Database=MinionsDB;Integrated Security=true";

        static void Main(string[] args)
        {
            using var connection = new SqlConnection(SqlConnectionString);
            connection.Open();

        }

        private static void InitialSetup(SqlConnection connection)
        {
            string createDataBase = "CREATE DATABASE MinionsDB";
            var createTableStatements = GetCreateTableStatements();
            foreach (var query in createTableStatements)
            {
                ExecuteNonQuery(connection, query);
            }

            var insertStatements = GetInsertDataStatements();

            foreach (var query in insertStatements)
            {
                ExecuteNonQuery(connection, query);
            }
        }

        private static void ExecuteNonQuery(SqlConnection connection, string query)
        {
            using var command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
        private static string[] GetInsertDataStatements()
        {
            var result = new string[]
            {
                "INSERT INTO Countries (Id, [Name]) VALUES (1, 'Bulagria'), (2, 'Norway'), (3, 'Cyprus'), (4, 'Greece'), (5, 'UK')",
                "INSERT INTO Towns (Id, [Name]) VALUES (1, 'Plovdiv'), (2, 'Oslo'), (3, 'Larnaca'), (4, 'Athens'), (5, 'London')",
                "INSERT INTO Minions (Id, [Name], Age, TownId) VALUES (1, 'Stoyan', 12, 1), (2, 'George', 22, 2), (3, 'Ivan', 25, 3), (4, 'Kiro', 35, 4), (5, 'Niki', 25, 5)",
                "INSERT INTO EvilnessFactors(Id, [Name]) VALUES (1, 'super good'), (2, 'good'), (3, 'bad'), (4, 'evil'), (5, 'super evil')",
                "INSERT INTO Villains (Id, [Name], EvilnessFactorId) VALUES (1, 'Gru', 1), (2, 'Ivo', 2), (3, 'Teo', 3), (4, 'Sto', 4), (5, 'Pro', 5)",
                "INSERT INTO MinionsVillains VALUES (1, 1), (2, 2), (3, 3), (4, 4), (5, 5)"
            };
            return result;
        }
        private static string[] GetCreateTableStatements()
        {
            var result = new string[]
            {
                "CREATE TABLE Countries(Id INT PRIMARY KEY NOT NULL, [Name] NVARCHAR (50))",
                "CREATE TABLE Towns(Id INT PRIMARY KEY NOT NULL,[Name] NVARCHAR (50),CountryCode INT FOREIGN KEY REFERENCES Countries(Id))",
                "CREATE TABLE Minions(Id INT PRIMARY KEY NOT NULL,[Name] NVARCHAR (50),Age INT,TownId INT FOREIGN KEY REFERENCES Towns(Id))",
                "CREATE TABLE EvilnessFactors(Id INT PRIMARY KEY NOT NULL,[Name] NVARCHAR (50))",
                "CREATE TABLE Villains(Id INT PRIMARY KEY NOT NULL,[Name] NVARCHAR (50),EvilnessFactorId INT FOREIGN KEY REFERENCES EvilnessFactors(Id))",
                "CREATE TABLE MinionsVillains(MinionId INT FOREIGN KEY REFERENCES Minions(Id),VillainId INT FOREIGN KEY REFERENCES Villains(Id)CONSTRAINT PK_MinionsVillains PRIMARY KEY(MinionId, VillainId))"

            };
            return result;
        }
    }
}
