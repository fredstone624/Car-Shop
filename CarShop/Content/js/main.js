function SubmitForm(name, email, car) {
    $.ajax({
        method: "POST",
        url: "/Home/Form",
        data: { Name: name, Email: email, Car: car }
    })
        .done(function (msg) {
            alert("Отлично: " + msg);
        }).fail(function () {
            alert("При передачи данных произошла ошибка");
        });
}

$("#form").submit(function () {

    var UserName    = $('input[name=Name]').val();
    var UserEmail   = $('input[name=Email]').val();
    var Car         = $('select[name=Car]').val();

    SubmitForm(UserName, UserEmail, Car);
});