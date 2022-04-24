# Discovery

### Whilst there are only 33 commits shown here, the following list of more than 175 distinctive steps, each of which might have involved multiple individual commits would have brought the total to over 1000 commits, so either way as a record of work activity these are simplifications


Creating the .Net API Project using the dotnet CLI.

Setting up VS code to work with C#.

Getting to know the API project files.

Creating intial Entitues.

Adding Entity Framework to use DbContext and migrations.

Adding a new API Controller.

Making  code Asynchronous.

 

Angular

Creating the Angular application.

Running and reviewing bootstrapping the app.

Adding VS Code extensions to work with Angular.

Making HTTP requests in Angular.

Adding CORS support in the API.

Displaying the fetched users in the browser.

Adding bootstrap and font-awesome. 
 
Safe storage of passwords.

Updating the user entity.

Creating a base API controller.

Creating an Account Controller with a register endpoint.

Using the debugger.

Using DTOs.

Adding validation.

Adding a login endpoint.

JSON web tokens.

Adding a token service.

Adding the create token logic.

Creating a User DTO and returning the token.

Adding the authentication middleware.

Adding extension methods.

Client login and register

Creating Angular client nav bar.

template forms and services.

Injecting services into components.

Conditionals to show and remove content.

Bootstrap components e.g dropdown.

Observables, persisting the login.

async pipes.

Parent child, child-parent communication.

client routing with nav links and in code.

Toast service for notifications and route guard.

Adding a dummy route.

Adding a new theme.

Error handling via error controller for testing errors.

Handling server errors.

Exception handling middleware, error interceptor.

Validation errors.

Handling not found.

API extensions

Extending the user entity

Adding a DateTime extension to calculate age.

Entity Framework relationships.

Generating seed data.

Creating a repository.

Updating the users controller.

Adding a DTO for Members.

Adding configuring and using AutoMapper.

Using AutoMapper queryable extensions.


Building the User Interface

Introduction.

Using TypeScript.

Creating the member interface.

Adding a member service.

Retrieving the list of members.

Creating styled member cards with animated buttons.

Using an interceptor to send the token.

Adding a photo gallery.


Creating a member edit component.

Creating the edit template form.

Adding the update functionality.

Adding a Can Deactivate route guard.

Persisting the changes in the API.

Updating the user in the client app.

Adding loading indicators.

Using the service to store state.

photo upload functionality

3rd part photo hosting API Cloudinary Account.

Configuring cloudinary in the API.

Using the Created At Route method.

Adding a photo editor component.

Adding a photo uploader.

Setting the main photo in the API.

Adding the main photo image to the nav bar.

Setting the main photo in the client.

Deleting photos - API.

Deleting photos - Client.

Reactive forms

Reactive forms with Client-side validation.

Adding custom validators.

Validation feedback.

Creating a reusable text input.

Using the form builder service.

Expanding the register form.

Adding a reusable date input.

Updating the API register method.

Client-side registration.



Paging, Sorting and Filtering

Adding a paged list class.

Adding helper classes for pagination.

Using the pagination classes.

Setting up client pagination.

Using the angular bootstrap pagination component.

Adding filtering to the API.

Adding additional filters.

Cleaning up the member service.

Adding filter buttons to the client.

Adding sorting functionality.

Adding an action filter.

Making the Last Active action filter more optimal.

Sorting on the client.

Formatting dates.

Restoring the caching for members.

Restoring caching for member detailed.

Remembering the filters for a user in the service.


Adding Feature User Likes 

Adding entity, repository and Implementation

Adding Feature messaging

Setting up the entities for messaging.

Setting up the message repository.

Setting up the automapper profiles.

Adding a message controller.

Getting the messages from the Repo.

Getting the message thread for 2 users.

Setting up the Angular app for messaging.

Designing the inbox.

Adding the message thread in the client.

Styling the message thread.

Activating the message tab.

Using query params.

Using route resolvers.

Sending messages.

Deleting messages on the API.

Deleting messages on the client.


Setting up Identity and role management entities.

 Configuring the DbContext.
 
 Configuring the startup class.
 
 Refactoring and adding a new migration / seeding
 
Updating the account controller.

Adding roles to the app.

Adding the roles to the JWT token.

Adding policy-based authorisation. 208

Getting the users with roles.

Editing user roles.

Adding an admin component.

Adding an admin guard.

Adding a custom directive.

Adding the edit roles component.

Setting up modals.

Editing roles in the client.

SignalR presence hub, authenticating Client. 

Adding aand displaying presence tracker.

Creating a message hub.

Adding the send message method to the hub.

Adding the hub connection to the message service.

Refactoring the message components to use the hub.

Sending messages via the hub.

Tracking the message groups.

Updating the message hub with group tracking.

Dealing with UTC date formats.

Notifying users when they receive a message.

Optimizing the presence and messages.

Applying Unit of work pattern and finishing touches

Refactoring the controllers to use the unit of work.

Query Optimization

UTC dates.

Adding a confirmation service to the angular app.

Getting the data from the confirmation modal.

Tidying up the member message component.

Photo management challenge.


Publishing

Preparing angular and serving this from the API server.

Adding a fallback controller.

Creating an angular production build.

Using branches in git and connecting Azure to GitHub.

Merging changes and redeploying.

