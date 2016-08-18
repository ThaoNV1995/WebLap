$(document).ready(function() {
    $("#a-login").click(function() {
        $("#full").fadeIn();
        $("#login-form").fadeIn();
    });
    $("#full").click(function() {
        $("#full").fadeOut();
        $("#login-form").fadeOut();
    });
});