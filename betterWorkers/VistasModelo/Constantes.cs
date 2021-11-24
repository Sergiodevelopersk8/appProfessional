using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace betterWorkers.VistasModelo
{
    public class Constantes
    {
        public static FirebaseClient firebase = new FirebaseClient("https://professionalservicesdb-default-rtdb.firebaseio.com/");
        public const string WebapyFirebase = "AIzaSyBFfiMNTvKjhvot7tlGnAxRDZvtv4g5ApA";
        public static string storage = "professionalservicesdb.appspot.com";
        public const string GoogleMapsApiKey = "AIzaSyBdqyfI_p_GPvrdnaRx8GyOg_etQlhoB6s";
    }
}
