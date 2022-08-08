function templateRow() {
    var template = "<tr>";
    template += ("<td>" + "123" + "</td>");
    template += ("<td>" + "Jorge Junior" + "</td>");
    template += ("<td>" + "Rodriguez Castillo" + "</td>");
    template += ("<td>" + "123" + "</td>");
    template += ("<td>" + "123" + "</td>");
    template += ("<td>" + "123" + "</td>");
    template += ("<td>" + "123" + "</td>");
    template += "</tr>";
    return template;
}

function addRow() {
    var template = templateRow();
    for (var i = 0; i < 10; i++) {
        $("#tbl_body_table").append(template);
    }
}

//Add data to DataTable tbl_Customers
function addRowDT(data) {
    var tabla = $("#tbl_customers").DataTable();
    for (var i = 0; i < data.length; i++) {
        tabla.fnAddData([
            data[i].ID,
            data[i].Plate,
            data[i].CustomerName,
            data[i].Phone,
            data[i].Email,
            '<button type="button" value="Actualizar" title="Actualizar" class="btn btn-primary btn-edit" data-target="#imodal" data-toggle="modal"><i class="fa fa-check-square-o" aria-hidden="true"></i></button>&nbsp;' +
            '<button type="button" value="Eliminar" title="Eliminar" class="btn btn-danger btn-delete"><i class="fa fa-minus-square-o" aria-hidden="true"></i></button>'
        ]);
    }
}


//Send Data to DataTable in ListCustomer Page with Ajax
function sendDataAjax() {
    $.ajax({
        type: "POST",
        url: "frmListCustomer.aspx/ListCustomer",
        data: {},
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (data) {
            addRowDT(data.d);
        }
    });
}

//Calling to SendDataAjax Function Javacsript
sendDataAjax(); 