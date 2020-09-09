$(document).ready(function () {
    var ad = document.getElementById("adex");
    var support = document.getElementById("ifadblocker");
    if ($("#adex").height() > 0 || $("#ifadblocker").height() > 0) {
        ad.style.display = "block";
        support.style.display = "none"
    } else {
        ad.style.display = "none";
        support.style.display = "block"
    }
});
