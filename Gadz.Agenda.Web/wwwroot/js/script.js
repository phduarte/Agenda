//Javascript Document
// ####################################################################################
function setCookie(c_name, value, exdays) {
    var exdate = new Date();
    exdate.setDate(exdate.getDate() + exdays);
    var c_value = escape(value) + ((exdays == null) ? "" : "; expires=" + exdate.toUTCString());
    document.cookie = c_name + "=" + c_value;
}

function getCookie(c_name) {
    var i, x, y, ARRcookies = document.cookie.split(";");
    for (i = 0; i < ARRcookies.length; i++) {
        x = ARRcookies[i].substr(0, ARRcookies[i].indexOf("="));
        y = ARRcookies[i].substr(ARRcookies[i].indexOf("=") + 1);
        x = x.replace(/^\s+|\s+$/g, "");
        if (x == c_name) {
            return unescape(y);
        }
    }
}

function numeros(b) {

    if (document.all || document.getElementById) // Internet Explorer   
        var tecla = event.keyCode;
    else if (document.layers) // Nestcape   
        var tecla = e.which;

    if (tecla != 13) {
        if ((tecla > 47 && tecla < 58)) // numeros de 0 a 9   
            return true;
        else {
            if (tecla != 8) // backspace   
                //event.keyCode = 0;   
                return false;
            else
                return true;
        }
    }
    else {
        return true;
    }
}

function contentResize() {

    var content = $("#content");

    if (content) {

        var total = $(window).height();

        var header = $("body > header").outerHeight();
        var status = $("#status").outerHeight();
        var footer = $("body > footer").outerHeight();

        total = total - header - status - footer - 1;

        if (total > 0) {
            content.css("height", total + "px");
            content.css("overflow-y", "hidden");
        }
    }
}

function centerInContent() {

    var box = $(".box-center");
    var content = $("#content");

    if (box && content) {

        var x = 0;

        x = content.height();

        x -= box.innerHeight();
        x = parseInt(x / 2);

        if (x > 0)
            box.css("margin-top", x);
    }
}

window.onload = function () {
    contentResize();
    centerInContent();
}

window.onresize = function () {
    contentResize();
    centerInContent();
}