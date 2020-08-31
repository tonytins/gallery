using Google.Cloud.Firestore;

namespace Tonytins.Models
{
    [FirestoreData]
    public class GalleryModel
    {
        [FirestoreProperty] public string Title { get; set; }

        [FirestoreProperty] public string Image { get; set; }

        [FirestoreProperty] public string Credits { get; set; }

        [FirestoreProperty] public string Copyrights { get; set; }
    }
}
