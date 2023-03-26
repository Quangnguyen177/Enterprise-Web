function DisplayResult(res) {
    $("#display-idea").html("")
    console.log(res)
    var element = ""
    if (res.length == 0) {
        $("#display-idea").html("<h5>No idea found!!</h3>")
    } else {
        for (var i = 0; i < res.length; i++) {
            element += '<div class="information_idea"> <div class="Infor_idea"> <div class="detail_idea nav_bar--item--separate2"> <div class="avata_information_idea"> <figure>'
            if (res.Anonymous) {
                element += '<a style="text-decoration: none"> <img style="width: 60px; height: 60px; border-radius: 50%; display: inline-block" src="/images/avatar_anonymous.png" alt="avatar" /> <div class="name_account"> <h4 style="font-size: 16px;padding-top: -600px; width: 230px;">Anonymous</h4><h5 style="font-size: 14px;padding-top: -600px; color: black; margin-left: 70px;">' + res[i].CreatedDate+'</h5></div> </a>'
            } else {
                element += '<a style="text-decoration: none" href="/Staff/Profile/' + res[i].OwnerId + '"> <img style="width: 60px; height: 60px; border-radius: 50%; display: inline-block" src="/Avatars/' + res[i].Avatar + '" alt="avatar" /> <div class="name_account"> <h4 style="font-size: 16px">' + res[i].OwnerName + '</h4><h5 style="font-size: 14px;padding-top: -600px; color: black; margin-left: 70px;">' + res[i].CreatedDate +'</h5></div> </a>'
            }
            element += '</figure> </div> <div class="content"> <div class="img_idea"> <div class="title_idea"> <div class="tag"> <a href="/staff/viewpage?pageNum=1&orderby=lastest&viewtype=cat&id=' + res[i].CateId + '"> <span>' + res[i].Category + '</span> </a> </div> <a href="/Staff/DetailIdea/' + res[i].IdeaId + '" style="text-decoration:none; color: black;"> <h1 class="lead" style="font-size: 1.3em">' + res[i].IdeaTile + '</h1> </a> </div> <div class="file_idea "> <a href="/Staff/DetailIdea/' + res[i].IdeaId + '" style="text-decoration:none; color: black;"> <h2 class="content_post">' + res[i].IdeaContent + '</h2> </a> </div> </div> </div> </div>'
            element += '<div class="felling  nav_bar--item--separate3"> <div class="more"> <ul class="felling_idea"> <li><a style="color:green"><i class="fa-regular fa-eye"></i></a>' + res[i].View + '</li> <li> <label placeholder="React point: "><p id="total">' + res[i].Point + '</p></label> </li> <li> <i type="button" onclick="btnThumbUp(this)" class="fa-regular fa-thumbs-up" style="color: green"></i> </li> <li> <i type="button" onclick="btnThumbDown(this)" class="fa-regular fa-thumbs-down" style="color:green"></i> </li> <li><a style="color:green" asp-action="" asp-controller=""><i class="fa-regular fa-comment"></i></a>' + res[i].CommentCount + '</li> </ul> </div> </div>'
            element += '<div class="comment_idea"> <div class="com_idea_avata"> <a href="/Staff/Profile/' + res[i].OwnerId + '"> <figure class="avata_comment"> <img style="width: 60px; height: 60px; border-radius: 50%; display: inline-block" src="/Avatars/' + res[i].UAvatar + '" alt="avata" /> </figure> </a> </div> <div class="comment" style=" position: static; z-index: 5;"> <div class="form-group"> <a href="/Staff/DetailIdea/' + res[i].IdeaId + '" style="text-decoration: none"> <input style="width: 80%; height: 40px" class="form-control" rows="5" id="comment" placeholder="Post your comment..." /> </a> </div> </div> </div> </div> </div>'
            $("#display-idea").append(element)
            element=''
        }
    }
}
   
function SearchSubmit() {
    if ($("#form1").val().length > 0) {       
        $.ajax({
            url: "/Staff/SearchIdea",
            type: "POST",
            data: {
                searchString: $("#form1").val(),
            },
            success: function (res) {
                var result = JSON.parse(res)
                DisplayResult(result)
                //if (result.Content != null) {
                //    $("#comment-numbers").html(`${result.ComNumber}`)
                //    if (result.Anonymous) {
                //        $("#display-comment").append('<div class="ap_idea_avata"> <figure class="account"> <a asp-action="Profile" asp-controller="Staff"> <img src="https://cdn.pixabay.com/photo/2016/04/01/10/11/avatar-1299805_1280.png" alt="avata" /> </a> </figure> </div>')
                //        $("#display-comment").append('<div class="info_comment"> <div class="comment1_idea"><h4 style="font-size: 16px; font-weight: bold;">Anonymous</h4><span>' + result.Content + '</span></div> <h5 style="font-size: 12px; width: 100%; color: dimgray;">' + result.Time + '</h5></div>')
                //    } else {
                //        $("#display-comment").append('<div class="ap_idea_avata"> <figure class="account"> <a asp-action="Profile" asp-controller="Staff"> <img src="/Avatars/' + result.Avatar + '" alt="avata" /> </a> </figure> </div>')
                //        $("#display-comment").append('<div class="info_comment"> <div class="comment1_idea"><h4 style="font-size: 16px; font-weight: bold;">' + result.Name + '</h4><span>' + result.Content + '</span></div> <h5 style="font-size: 12px; width: 100%; color: dimgray;">' + result.Time + '</h5></div>')
                //    }
                //}
            },
            error: function (err) {

                console.log(err)
            }
        })
    }
}



$("#form1").keyup(function (event) {
    if (event.keyCode === 13) {
        SearchSubmit()
        $("#form1").val("");
    }
});
