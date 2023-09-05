
const GetCandidateDetails = async () => {
   var Response;

    try {
        await $.ajax({
            type: 'GET',
            url: "https://localhost:7138/api/User/GetUserDetails",
            contentType: "application/json",
            data: {},
            async: false,
            success: function (data) {
                if (data != null && data.statusCode == 200) {
                    if (data.resultData.length > 0) {
                        var tbodydata = '';
                        $.each(data.resultData, function (key, value) {
                            tbodydata += '<tr class="jsgrid-row">';
                            tbodydata += '<td class="jsgrid-cell">' + value.userName + '</td>';
                            tbodydata += '<td class="jsgrid-cell">' + value.email + '</td>';
                            tbodydata += '<td class="jsgrid-cell">' + value.address + '</td>';
                            tbodydata += '<td class="jsgrid-cell">' + value.dob + '</td>';
                            tbodydata += '<td class="jsgrid-cell">' + value.genderId + '</td>';
                            tbodydata += '<td class="jsgrid-cell">' + value.mobileNo + '</td>';
                            tbodydata += '<td class="jsgrid-cell">' + value.qualification + '</td>';
                            tbodydata += '<td class="jsgrid-cell">' + value.specialization + '</td>';
                            tbodydata += '<td> <a href = "/AddCandidate?UserId='+ value.userId + '"><span class="jsgrid-button jsgrid-edit-button ti-pencil" type="button" title="Edit"></span></a><a href = "#"onclick="DeleteCandidateById(' + value.userId + ')"><span class="jsgrid-button jsgrid-delete-button ti-trash" type="button" title="Delete"></span></a></td>';
                             tbodydata += '</tr>';
                        });
                        console.log(tbodydata);

                        $("#tblCandidate tbody").empty();
                        $("#tblCandidate tbody").append(tbodydata);
                    }
                }
            }
        });
    }
    catch (err) {
        await console.log(err);
    }

    return Response;
}


const GetCandidateDetailsById = async (Id) => {
    
    var Response = 0;


    try {
        await $.ajax({
            type: 'GET',
            url: "https://localhost:7138/api/User/GetUserDetailsByIdAsync?id="+Id,
            contentType: "application/json",
            data: { id: Id },
            async: false,
            success: function (data) {
                
                if (data != null && data.statusCode == 200) {
                    $('#hdnUserId').val(data.resultData.UserId);
                    $('#userName').val(data.resultData.userName);
                    $('#password').val(data.resultData.password);
                    $('#email').val(data.resultData.email);
                    $('#address').val(data.resultData.address);
                    $('#regDate').val(data.resultData.regDate);
                    $('#dob').val(data.resultData.dob);
                   // $('#dob').datepicker("setDate", data.resultData.dob);
                    data.resultData.genderId == 1 ? $('#Male').attr('checked', true) : data.resultData.genderId == 2 ? $('#Female').attr('checked', true) :
                        $('#Others').attr('checked', true);
                    $('#mobileNo').val(data.resultData.mobileNo);
                    $('#qualification').val(data.resultData.qualification);
                    $('#specialization').val(data.resultData.specialization);
                    $('yearId').val(data.resultData.yearId);
                    $('batchId').val(data.resultData.batchId);
                    $('roleId').val(data.resultData.roleId);


                }
            }
        });
    }
    catch (err) {
        await console.log(err);
    }

    return Response;
}

//save or update candidate Details
const SaveOrUpdateCandidate = async (Id) => {
    var Response = 0;
   // alert(Id);
    var data = {
        UserId: Id,
        UserName: $('#userName').val(),
        Email: $('#email').val(),
        Address: $('#address').val(),
        DOB: new Date($('#dob').val()) ,
        GenderId: $('#genderId').val(),
        MobileNo: $('#mobileNo').val(),
        Qualification: $('#qualification').val(),
        Specialization: $('#specialization').val(),


    }
    console.log('data', data);
    alert()
    $.ajax({
        type: 'POST',
        url: "https://localhost:7138/api/User/InsertUserDetailsAsync",
        contentType: "application/json",
        data: JSON.stringify(data),
        async: false,
        success: function (data) {
            console.log('data', data);
            alert("save success")
            if (data != null && data.statusCode == 200) {
                window.location.href = "/Administrations/Administrations";
            }
        }
    });
}

//Delete the Candidate Details
const DeleteCandidateById = async (Id) => {
    var Response = 0;


    try {
        await $.ajax({
            type: 'DELETE',
            url: 'https://localhost:7138/api/User/DeleteUserDetailsByIdAsync?id=' + Id + '',
            contentType: "application/json",
            data: { id: Id },
            async: false,
            success: function (data) {
                if (data != null && data.statusCode == 200) {
                    alert("Deletd Sucessfully");
                    GetCandidateDetails();
                }
            }
        });
    }
    catch (err) {
        await console.log(err);
    }

    return Response;

}

