window.onload = function () {
    getBlogs();
}

function getBlogs() {
    fetch("api/blogs", { method: "GET" })
        .then(function (response) {
            return response.json();
        })
        .then(function (blogsJson) {
            let json = JSON.stringify(blogsJson);
            let blogs = JSON.parse(json);
        })
}

