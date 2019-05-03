#Extras
1. Modularized the setup of the main form using a specific method that would prepare the contents of each tab page.
2. Used both DataGridView and ListView; DataGridView for information that don't need to be loaded as quickly (eg. information in another form as modal).
3. Built a generic form for each api endpoint to not only speed development, but to further separation of concerns. (One modal per section that needed a modal).
4. Built generic event handlers that would be used per setup method to reuse code and further development time.
5. Stripped the default form look to make the form more customzied and more appeasing to the eye.

tldr: Used reusable code wherever possible. Made the form overall look a bit better than the default look.