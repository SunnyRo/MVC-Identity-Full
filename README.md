# **PlayerWeb**

### App that create a database and table bound to model Code first approach

### Added view and controller which allows users to do some CRUD Operations with bot table in the database

### Added AppUser inherit from IdentityUser

### Applied build-Identity to the app which requires users to log in before doing any CRUD Operations with bot table. (Appear Bot in navigation bar after log in and user cannot access bot page directly through the url if they are not logged in)

### Added Role (Get,Create,Delete)

### Added User (Add,Remove user from a role)

### Added AccessDenied for Privacy page (only Admin role can see) !!!attention user still have to re login whenever they are added to Admin group in order to access privacy page.

### Added User's Profile (where user can see their information First name and last name)

### Added Edit popup modal (where users can update their first name and last name)

# **How to run**

### Correct the ConnectionStrings in appsetting.json to match with your database server

### Use "Update-Database" to package Manager Console to create Player table
