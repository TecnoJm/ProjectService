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

var tabla, data

//Add data to DataTable tbl_customers
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

//Edit, Delete and Update buttons
$(document).on('click', '.btn-edit', function (e) {
    e.preventDefault();
     
    var row = $(this).parent().parent()[0];
    data = tabla.fnGetData(row);
    console.log(data);
    fillModalData();

});

$(document).on('click', '.btn-delete', function (e) {
    e.preventDefault();
    console.log("Delete");
});

$(document).on('click', '.btnupdate', function (e) {
    e.preventDefault();
    updateDataAjax();
});

//Load Data in Modal
function fillModalData() {
    $("#txtCustomerPlateModal").val(data[1]);
    $("#txtCustomerNameModal").val(data[2]);
    $("#txtCustomerPhoneModal").val(data[3]);
    $("#txtCustomerEmailModal").val(data[4]);
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


function updateDataAjax() {

    var obj  = JSON.stringify({ id: JSON.stringify(data[1]), direccion: $("#txtCustomerPlateModal").val() });
    var obj2 = JSON.stringify({ id: JSON.stringify(data[1]), direccion: $("#txtCustomerNameModal").val() });
    var obj3 = JSON.stringify({ id: JSON.stringify(data[1]), direccion: $("#txtCustomerPhoneModal").val() });
    var obj4 = JSON.stringify({ id: JSON.stringify(data[1]), direccion: $("#txtCustomerEmailModal").val() });

    $.ajax({
        type: "POST",
        url: "frmListCustomer.aspx/UpdateCustomer",
        data: obj, obj2, obj3, obj4,
        dataType: "json",
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (response) {
            if (response.d) {
                alert("Record updated!");
            } else {
                alert("Could not update record!");
            }
        }
    });
}


//Calling to SendDataAjax Function Javacsript
sendDataAjax(); 