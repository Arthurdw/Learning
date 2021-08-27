namespace Blobs
{
    internal class SqlStatementsDataset
    {
        public static string AddBlob = "INSERT INTO blobs (name, data) " +
                                       "VALUES (@name, @data);";

        public static string GetLatestBlob = "SELECT name, data " +
                                             "FROM blobs " +
                                             "ORDER BY date DESC " +
                                             "LIMIT 1;";

        public static string GetSpecificImage = "SELECT name, data " +
                                                "FROM blobs " +
                                                "WHERE LOWER(name) = LOWER(@name);";
    }
}