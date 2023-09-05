//Login process
const Login = async () => {
    var Response = 0;
    
    var data = {
        userName: $('#userName').val(),
        password: $('#password').val(),

    }
    console.log('data----', data);
    
    $.ajax({
        type: 'POST',
        url: "https://localhost:7138/api/Login/SaveLoginDetails",
        contentType: "application/json",
        data: JSON.stringify(data),
        async: false,
        success: function (data) {
            
            console.log('data', data);
          
            if (data != null && data.statusCode == 200) {
                alert("save success")
                window.location.href = "/dashboard";
            }
            else {
                alert('Invalid User Name and Password...');
            }
          
        },
        error: function (error) {
           // alert('Invalid User Name and Password...');
}
    });
}













 // $(".sidebar").css("display", "block");
          //  $(".header").css("display", "block");
          //  $(".content-wrap").css("margin-left", "250px");
