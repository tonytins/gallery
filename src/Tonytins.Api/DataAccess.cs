using System;
using System.IO;
using Google.Cloud.Firestore;

namespace Tonytins.Api
{
    public static class DataAccess
    {
        public static FirestoreDb Firestore
        {
            get
            {
                var path = Path.Combine(AppContext.BaseDirectory, "tonytins-63f17-firebase-adminsdk-8rgen-7f96f7858d.json");
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
                return FirestoreDb.Create("tonytins-63f17");
            }
        }
    }
}
