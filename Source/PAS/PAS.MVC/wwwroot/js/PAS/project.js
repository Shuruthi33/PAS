
// GET the Project Details
const GetProjectDetails = async () => {
    debugger;
    var Response;

    try {
        await $.ajax({
            type: 'GET',
            url: "https://localhost:7138/api/Project/GetProjectDetails",
            contentType: "application/json",
            data: {},
            async: false,
            success: function (data) {
                if (data != null && data.statusCode == 200) {
                    if (data.resultData.length > 0) {
                        var tbodydata = '';
                        debugger;
                        $.each(data.resultData, function (key, value) {
                            tbodydata += '<tr class="jsgrid-row">';
                            tbodydata += '<td class="jsgrid-cell">' + value.prjTitle + '</td>';
                            tbodydata += '<td class="jsgrid-cell">' + value.prjScope + '</td>';
                            tbodydata += '<td class="jsgrid-cell">' + value.prjAnnouncement + '</td>';

                            tbodydata += '<td> <a href="/AddOrUpdateStudentDetails?StudentId=' + value.studentId + '"><span class="jsgrid-button jsgrid-edit-button ti-pencil" type="button" title="Edit"></span></a><a href = "#"onclick="DeleteCandidate(' + value.userId + ')"><span class="jsgrid-button jsgrid-delete-button ti-trash" type="button" title="Delete"></span></a></td>';
                            //tbodydata += '<td> <a href="/AddOrUpdateStudentDetails?StudentId=' + value.UserId +'"><span class="jsgrid-button jsgrid-edit-button ti-pencil" type="button" title="Edit"></span></a>< a href = "#"onclick = "DeleteCandidate(' + value.userId + ')" > <span class="jsgrid-button jsgrid-delete-button ti-trash" type="button" title="Delete"></span></a ></td > ';
                            tbodydata += '</tr>';
                        });

                        $("#tblProjectId tbody").empty();
                        $("#tblProjectId tbody").append(tbodydata);
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

// Get Project ById
const GetProjectDetailsById = async (Id) => {
    var Response = 0;


    try {
        await $.ajax({
            type: 'GET',
            url: "https://localhost:7138/api/Project/GetProjectDetailsByIdAsync?",
            contentType: "application/json",
            data: { id: Id },
            async: false,
            success: function (data) {
                debugger
                if (data != null && data.statusCode == 200) {
                    $('#hdnProjectId').val(data.resultData.UserId);
                    $('#prjTitle').val(data.resultData.userName);
                    $('#prjScope').val(data.resultData.password);
                    $('#prjAnnouncement').val(data.resultData.email);

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
const SaveOrUpdateProject = async () => {
    var Response = 0;

    var data = {
        userId: parseInt($('#hdnProjectId').val()),
        userName: $('#prjTitle').val(),
        password: $('#prjScope').val(),
        email: $('#prjAnnouncement').val(),


    }
    console.log('data', data);
    alert()
    $.ajax({
        type: 'POST',
        url: "https://localhost:7138/api/Project/InsertProjectDetailsAsync",
        contentType: "application/json",
        data: JSON.stringify(data),
        async: false,
        success: function (data) {
            console.log('data', data);
            alert()
            if (data != null && data.statusCode == 200) {
                window.location.href = "/Administrations/Administrations";
            }
        }
    });
});


//Delete the Project Details By Id
const DeleteProjectById = async (Id) => {
    var Response = 0;


    try {
        await $.ajax({
            type: 'DELETE',
            url: 'https://localhost:7138/api/Project/DeleteProjectDetailsByIdAsync' + Id + '',
            contentType: "application/json",
            data: { id: Id },
            async: false,
            success: function (data) {
                if (data != null && data.statusCode == 200) {
                    alert("Deletd Sucessfully");
                    GetProjectDetails();
                }
            }
        });
    }
    catch (err) {
        await console.log(err);
    }

    return Response;

}
