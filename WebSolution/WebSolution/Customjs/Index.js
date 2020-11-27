$(document).ready(function () {

    function IndexVM() {

        var self = this;
        self.tittle = ko.observable();
        //self.Id = ko.observable();
        //self.Name = ko.observable();
        self.PostList = ko.observableArray([]);

        
        self.SearchPost = function () {
            var a = "";
            $.ajax({
                type: "GET",
                url: 'http://localhost:58275/api/Solution/SearchPost?tittle=' + self.tittle(),
                contentType: "application/json",
                success: function (data) {
                    if (data != null) {
                        self.PostList(data);
                    }
                },
                error: function () {
                    //alert(error.status + "<--and--> " + error.statusText);
                }
            });
        }
        self.Like = function (data) {
            var a = "";
            $.ajax({
                type: "Post",
                url: 'http://localhost:58275/api/Solution/SetLike?commentId=' + data.Id,
                contentType: "application/json",
                success: function (data) {
                    if (data != null) {
                        //self.PostList(data);
                        self.LoadPost();
                    }
                },
                error: function () {
                    //alert(error.status + "<--and--> " + error.statusText);
                }
            });
        }
        self.Dislike = function (data) {
            $.ajax({
                type: "Post",
                url: 'http://localhost:58275/api/Solution/SetDisLike?commentId=' + data.Id,
                contentType: "application/json",
                success: function (data) {
                    if (data != null) {
                        self.LoadPost(data);
                    }
                },
                error: function () {
                    //alert(error.status + "<--and--> " + error.statusText);
                }
            });
        }
        self.LoadPost = function () {
            $.ajax({
                type: "GET",
                url: 'http://localhost:58275/api/Solution/GetAllPosts',
                contentType: "application/json",
                success: function (data) {
                    if (data != null) {
                        self.PostList(data);
                    }
                },
                error: function () {
                    alert(error.status + "<--and--> " + error.statusText);
                }
            });
        }
        self.InitialValueLoad = function () {
            self.LoadPost();
        }

    }
    var vm = new IndexVM();
    vm.InitialValueLoad();
    ko.applyBindings(vm, $('#IndexVM')[0]);
})