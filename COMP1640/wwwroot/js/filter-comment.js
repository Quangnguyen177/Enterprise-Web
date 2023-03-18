function FilterComment(ideaId, order) {
    console.log(ideaId, order)
    var req = {
        id: ideaId,
        order: order
    }
    $.ajax({
        url: "/Staff/FilterComment",
        method: "POST",
        data: req,
        success: function (res) {
            var data = JSON.parse(res)
            console.log(data)
            $("#display-comment").html("")
            let avatar;
            let name;
            for (let i = 0; i < data.length; i++) {
                if (data[i].anonymous) {
                    avatar = "https://cdn.pixabay.com/photo/2016/04/01/10/11/avatar-1299805_1280.png"
                    name = "Anonymous"
                } else {
                    avatar = '/Avatars/' + data[i].avatar;
                    name = data[i].name;

                }
                var elements = '<div class="ap_idea_avata"> <figure class="account">'
                elements += '<a asp-action="Profile" asp-controller="Staff" ><img src="' + avatar + '" alt="avatar" /></a></figure>'
                elements += '<div class="info_comment"><div class="comment1_idea"> <h4 style="font-size: 16px; font-weight: bold;">' + name + '</h4 >'
                elements += '<span>' + data[i].content + '</span> </div > <h5 style="font-size: 12px; width: 100%; color: dimgray;">' + data[i].time + '</h5></div></div>'
                $("#display-comment").append(elements)
            }
        },
        error: function (err) {

            console.log(err)
        }
    })
}

