$(document).ready(function () {
    $("#SubmitItemForm").on('submit', function (e) {
        e.preventDefault();
        var form = $('#SubmitItemForm');
        $.ajax({
            method: 'post',
            url: form.attr('action'),
            data: form.serialize(),
            success: function (response) {
                window.parent.location.reload();
            },
            error: function (xhr, status, errorcode) {
                var result = JSON.parse(xhr.responseText);
                form.append(result);
            }
        });
    });
});