$(document).ready(function () {
    var ad = document.getElementById("adex");
    if ($("#adex").height() > 0 || $("#ifadblocker").height() > 0) {
        ad.style.display = "block";
    } else {
        ad.style.display = "none";
    }
});
