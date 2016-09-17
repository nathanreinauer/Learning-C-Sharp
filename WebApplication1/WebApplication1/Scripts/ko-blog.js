var viewModel =
{
    blogs: ko.observableArray([]),
    newBlog: function () {
        this.blogs.push({
            Title: ko.observable("New " + this.blogs().length),
            Id: ko.observable(this.blogs().length + 1),
            Post: ko.observable("Post " + this.blogs().length),
            IsNew: ko.observable(true),
            IsDeleted: ko.observable(false)
        });
    }
}

$(document).ready(function ()
{
    $(".right-section").hide();
    $.ajax(
    {
        url: "/api/Blogs",
        contentType: "text/json",
        type: "GET",
        success: function (data)
        {
            $.each(data, function (index)
            {
                viewModel.blogs.push(toKoObserable(data[index]));
            });
            ko.applyBindings(viewModel);
        },
        error: function (data)
        {
            alert("ERROR");
        }
    });

    function toKoObserable(blog)
    {
        return {
            Id: ko.observable(blog.Id),
            Title: ko.observable(blog.Title),
            Post: ko.observable(blog.Post),
            Comments: ko.observable(blog.Comments),
            IsDeleted: ko.observable(blog.IsDeleted)
        };
    }
})