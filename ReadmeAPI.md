#  WORK IN PROGRESS

# Client

Extracts from dev log.
✓. This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 10.1.0.

✓. Initial client registration implemented  as  a template form changed from  to Reactive Form.

✓. Reactive Reuseable Reactive form Controls used to replace initial reactive inputs.

✓. Client side validation added with user feedback and custom validator.

✓. Basic password requirements maintained for dev's simple          interactions as user.

✓. Simple i18n functionality added thus far
comment: Returning the what server side detection of the accept language finds in the client request header to a general client application wide angular service
is a fairly standard approach to deciding what language to present the opening screen and controls in, with the lazy loading of feature based modules
it suggest the translated "labels" be loaded along with other feature components as part of the lazy approach.
If the user selects another language other than that first detected then updating other requested features already loaded will be needed. 

✓. Form builder service added to initialize registration form.

## incomplete

✗. Spinning wheel of patience not added yet

✗. Further toaster popups delayed

✗. photoUrl prop missing from client model added but not documented in wiki


## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `--prod` flag for a production build.

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI README](https://github.com/angular/angular-cli/blob/master/README.md).



This project serves to demonstrate the application of specific areas of technology involved in the
construction of a full stack Angular plus .NET Web Application.

The project involves the extensive and repeated use of the Dotnet and Angular CLI’s and 
at least one IDE.

Whilst many developers prefer either Visual Studio or Visual Studio Code my experience
preference is not to make a binary choice. Visual Studio can be a little harder to configure
but once it is setup there are no significant issues.

My personal preference is to use both, sometimes together. Visual Studio has clearly more
debugging features and doesn't require restarting, Visual Studio Code, along with the CLI's
are quicker to navigate and seem to consume less memory.


The remainder of this document will be a two column table like
structure, with the technical features on
the left and the area/s where they were applied within the Web Application on the right

| techical feature                               | Cool  |
| --------------------------------------------:| ----:|
| col 3 is                                          | cubit007 |
| col 2 is                                           |   yyyy |
| quantum       |    1 |



API Controllers and Endpoints, Entity Framework, API and Angular Project Structures, Configuration and Environment
Source Control 🟡 regular commits, use of branches, merging and CD/CI options

Components, template and reactive forms, services, structural directives, 
two way parent child communication, routing, route guards, common modules,
interceptors, EF relationships, conventions, seeding data, repo pattern AutoMapper
API middleware

Sec9
Typescript Types, 
Interceptors sending JWT tokens
Bootstrap styling
3rd party photo gallery
Route params
Implement persistence when updating resources in the API.

More on Template forms, CanDeactivate Route guard, @ViewChild decorator
Persisting changes to the API, client loading indicator
Caching data in Angular Services

Sec 11
Photo storage options, adding related entities, 3rd party API’s, Debugger+, 
updating and deleting resources and returning codes from REST based endpoints.
Angular data inputs,reuseable reactive form controls, angular validation
Sec 12 

API based pagination, sorting, filtering with related Angular implementations.
Defered execution with IQueryable, client action filters, currency, time presentation pipes
and client caching options for paginated resources.

Sec 14 
Many to many relationships and configuring DBContext entities
Implement Messaging functionality using Angulars query params and route resolvers.

Sec 16
Implementing .Net Identity, Role management with policy based authorisation.
Extensive use of Generics UserManager<T> SignInManager<T>, RoleManager<T>
 SignalR implementation on the Servers API and client for realtime presence and message exchange

Unit of Work pattern, database query optimisation 
Client side Dialogues / modals

Creating production builds and deploying from Visual Studio / VSC to Azure options and other 3rd party hosting providers like  Heroku and Webecs.
Unit testing with xUnit or Nunit, Jasmine and Karma…needs more explanation



Application level features, server side implementations of repository pattern
Creating repository interfaces, implementing repository methods


Application level architecture, implementing the unit of work pattern
Server and client side implementations of the dependency injection pattern, use of static methods,
singletons and reuseable services.
Lazy Loading


7.	Extending the API,
8.	 Building the User Interface







## Running unit tests

Run `npmcd test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via [Protractor](http://www.protractortest.org/).
