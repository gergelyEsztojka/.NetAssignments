window.onload = function () {
    getBlogs();
}

function getBlogs() {
    fetch("api/blogs", { method: "GET" })
        .then(function (response) {
            return response.json();
        })
        .then(function (blogsJson) {
            console.log(blogsJson[0]);
        })
}

