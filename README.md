# Instructions to run solution:
1. Open solution file
2. Set Start-up projects to Mfm.RailtownAi.App and Mfm.RailtownAi.TestApp
3. Press Start button.

# Integration with Azure Build Pipeline:
- Per commit, a build starts on AzureDevOps
- 

------

# Railtown AI  Back End Technical Assessment

## submitting your code

Please create your own repository on GitHub and check in your code there.

## goals

The purpose of this technical assessment is to gauge your abilities and to see how you approach a project.

- Take whatever time you need to setup your environment but once you start coding you should spend between **(2 to 4 hours)**.
- You are NOT required or expected to complete everything. Simply do what you can in the time allotted.
- Focus on the areas which you believe to be important and will best reflect your abilities.
- Be prepared to talk about challenges, next steps and the code you wrote during the next interview.
- If you have any questions feel free to reach out.
- When you are done please check your work into your own github repository and let us know you're finished by email.

## requirements

You will be developing a program that accesses a data source of users. The program should call the webservice and then return the two users who are geographically the farthest from each other. For example, if there are three users, one in Vancouver, one in Calgary, and one in Toronto, the webservice should return the users in Vancouver and Toronto. The program should return the following output for both users:
name, address, company name, phone, distance from other user

- The program must be written in C# and you may use third party libraries (eg. nuget packages)
- You can choose any UI technology (e.g. ASP.NET web app/service, Windows Forms, or even a good old console app) but be prepared to explain the reasons for your choice.
- The output can be in any format (eg. xml/html/json/csv)
- The program should obtain the data from https://jsonplaceholder.typicode.com/users 
- The program can be run on-demand or at certain intervals (eg. every 5 mins)
## Bonus for Demonstrating More Senior Skills:
- Bonus: describe the time and space complexity of your geographic algorithm
- Bonus: geographic algorithm runs in O(n*log*n) time
- Bonus: proper use of code/architecture patterns 
- Bonus: deploy your solution to Azure

## tests

Please demonstrate how you can validate the code you've written using automated tests

## data

All the data you will need can be retrieved from [jsonplaceholder](https://jsonplaceholder.typicode.com/users). Here is a sample: 

`
[{"id":1,"name":"Leanne Graham","username":"Bret","email":"Sincere@april.biz","address":{"street":"Kulas Light","suite":"Apt. 556","city":"Gwenborough","zipcode":"92998-3874","geo":{"lat":"-37.3159","lng":"81.1496"}},"phone":"1-770-736-8031 x56442","website":"hildegard.org","company":{"name":"Romaguera-Crona","catchPhrase":"Multi-layered client-server neural-net","bs":"harness real-time e-markets"}},{"id":2,"name":"Ervin Howell","username":"Antonette","email":"Shanna@melissa.tv","address":{"street":"Victor Plains","suite":"Suite 879","city":"Wisokyburgh","zipcode":"90566-7771","geo":{"lat":"-43.9509","lng":"-34.4618"}},"phone":"010-692-6593 x09125","website":"anastasia.net","company":{"name":"Deckow-Crist","catchPhrase":"Proactive didactic contingency","bs":"synergize scalable supply-chains"}},{"id":3,"name":"Clementine Bauch","username":"Samantha","email":"Nathan@yesenia.net","address":{"street":"Douglas Extension","suite":"Suite 847","city":"McKenziehaven","zipcode":"59590-4157","geo":{"lat":"-68.6102","lng":"-47.0653"}},"phone":"1-463-123-4447","website":"ramiro.info","company":{"name":"Romaguera-Jacobson","catchPhrase":"Face to face bifurcated interface","bs":"e-enable strategic applications"}}]
`
