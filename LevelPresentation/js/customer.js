function templateRow() {
    var template = "<tr>";
    template += ("<td>" + "" + "</td>");
    template += ("<td>" + "" + "</td>");
    template += ("<td>" + "" + "</td>");
    template += ("<td>" + "" + "</td>");
    template += ("<td>" + "" + "</td>");
    template += ("<td>" + "" + "</td>");
    template += ("<td>" + "" + "</td>");
    template += "</tr>";
    return template;
}

function addRow() {
    var template = templateRow();
    for (var i = 0; i < 10; i++) {
        $("#tbl_body_table").append(template);
    }
}

/*

function addRowDT(data) {
    var tabla = $("#tbl_customers").DataTable();
    for (var i = 0; i < data.length; i++) {
        tabla.fnAddData([
            data[i].ID,
            data[i].Customer,
            data[i].Phone,
            data[i].Email
        ]);
    }
}

function sendDataAjax() {
    $.ajax({
        type: "POST",
        url: "frmCustomer.aspx/ListCustomer",
        data: {},
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (data) {
            console.log(data);
            //addRowDT(data.d);
        }
    });
}

//Calling to SendDataAjax Function Javacsript
sendDataAjax(); */