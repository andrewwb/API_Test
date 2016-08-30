namespace APITest.Controllers {

    export class HomeController {
        public books;

        constructor(public $http: ng.IHttpService) {
            $http.get('api/books').then((res) => {
                this.books = res.data;
            })
        }

    }



    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
