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

//Add data to DataTable tbl_oilservices
function addRowDT(data) {
    var tabla = $("#tbl_oilservices").DataTable();
    for (var i = 0; i < data.length; i++) {
        tabla.fnAddData([
            data[i].CustomerPlate,
            data[i].CustomerName,
            data[i].CustomerPhone,
            data[i].Grade,
            data[i].Miles,
            data[i].OilType,
            data[i].TodayDate,
            data[i].ChangeDate
        ]);
    }
}


//Send Data to DataTable in ListOilService Page with Ajax
function sendDataAjax() {
    $.ajax({
        type: "POST",
        url: "frmListOilService.aspx/ListOilService",
        data: {},
        contentType: 'application/json; charset=utf-8',
        error: function (xhr, ajaxOptions, thrownError) {
            console.log(xhr.status + " \n" + xhr.responseText, "\n" + thrownError);
        },
        success: function (data) {
            console.log(data.d);
            //addRowDT(data.d);
        }
    });
}


//Calling to SendDataAjax Function Javacsript
sendDataAjax(); 