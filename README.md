# To run the program:

If you're new to dotnet, once you download the project,
navigate in your terminal to the directory in which the csproj file resides in.

Once there, use `dotnet run` to locally host the project (localhost:5000).
You can use `Ctrl+C` in the terminal again to end the connection for the local hosting.

If you're editing the project, `dotnet watch run` will give you a live server that will refresh on file save.

## Project tidbits:

This project was just me refreshing myself on using Razor again after working with console and windows forms
over a long period of time.

What you will see when running the project is a list of "foods".
If one of the foods starts with 'c' or 'C', then the list item for the food will be red instead.
The logic is done entirely through Razor in the Index View page.
