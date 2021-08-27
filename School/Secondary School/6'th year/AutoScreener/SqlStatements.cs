namespace AutoScreener
{
    internal static class SqlStatements
    {
        public static string InsertStatement = "INSERT INTO to_blobs (ref_nr, afb) VALUES (@id, @image);";
        public static string FetchStatement = "SELECT afb FROM to_blobs WHERE ref_nr = @refnr;";
        public static string UpdateImageStatement = "UPDATE to_blobs SET afb = @image WHERE ref_nr = @id;";
        public static string UpdateTextStatement = "UPDATE to_blobs SET ref_nr = @newId WHERE ref_nr = @id;";
    }
}