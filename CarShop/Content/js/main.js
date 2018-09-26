function SubmitForm(name, email, car) {
    $.ajax({
        method: "POST",
        url: "/Home/Form",
        data: { userName: name, userEmail: email, carId: car }
    })
        .done(function (msg) {
            alert("Отлично:\n" + msg);
        }).fail(function () {
            alert("При передачи данных произошла ошибка");
        });
}

$(document).on('submit', '#form', function () {
    var Name    = $('input[name=Name]').val();
    var Email   = $('input[name=Email]').val();
    var Car     = $('select[name=Car]').val();

    SubmitForm(Name, Email, Car);
})