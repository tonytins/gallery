// Anthony Leland licenses this file to you under the MIT license.
using Google.Cloud.Firestore;

namespace Tonytins.Models
{
    /// <summary>
    /// Basic hero profile contains the type, affilation and server.
    /// If no info is given, the model uses it's defualt values.
    /// </summary>
    [FirestoreData]
    public class HeroModel
    {
        const string NA = "N/A";
        const string DEFAULT_SERVER = "Freedom";

        [FirestoreProperty] public string Name { get; set; } = "Example Hero";
        [FirestoreProperty] public string Origin { get; set; } = NA;
        [FirestoreProperty] public string Archetype { get; set; } = NA;
        // I'm not sure if Affilation needs to be an array
        [FirestoreProperty] public string Affilation { get; set; } = string.Empty;
        [FirestoreProperty] public string Primary { get; set; } = NA;
        [FirestoreProperty] public string Secondary { get; set; } = NA;
        [FirestoreProperty] public string Supplemental { get; set; } = string.Empty;
        [FirestoreProperty] public string Image { get; set; } = "coh-card.png";
        [FirestoreProperty] public string Server { get; set; } = DEFAULT_SERVER;
        [FirestoreProperty] public string Shard { get; set; } = DEFAULT_SERVER;
    }
}
