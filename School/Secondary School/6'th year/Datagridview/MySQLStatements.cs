namespace Datagridview
{
    internal static class MySQLStatements
    {
        public static string FetchAllData = @"SELECT Voornaam, Naam, StraatNrBus, Postcode, Stad, TelGSM, Gebdatum, IDlid FROM wn_leden;";

        public static string InsertUser = @"INSERT INTO wn_leden (Voornaam, Naam, StraatNrBus, Postcode, Stad, TelGSM, Gebdatum) " +
                                          @"VALUES (@Voornaam, @Naam, @StraatNrBus, @Postcode, @Stad, @TelGSM, @Gebdatum);";

        public static string UpdateUser = @"UPDATE wn_leden SET Voornaam = @Voornaam, Naam = @Naam, StraatNrBus = @StraatNrBus, Postcode = @Postcode, Stad = @Stad, TelGSM = @TelGSM, Gebdatum = @Gebdatum " +
                                          @"WHERE IDlid = @id;";

        public static string DeleteUser = @"DELETE FROM wn_leden WHERE IDlid = @id;";
    }
}