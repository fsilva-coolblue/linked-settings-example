# linked-settings-example
Exemplifies how to use linked app settings in Visual Studio


In this solution, the `ConfigLinkTest` project uses `<appSettings>` linked from the file `Settings.config`.
That file is actually defined in the `Settings` project, and only linked to `ConfigLinkTest`.

This serves to illustrate how a multi-project solution can use a single settings file, shared among its projects.

Noteworthy things:

[The settings file](Settings/Settings.config)

[Using the settings file](ConfigLinkTest/App.config#L4)

[The link to the settings file](ConfigLinkTest/ConfigLinkTest.csproj#L51)
(To do this in Visual Studio, simply drag the file over to the project while pressing `Ctrl+Shift`. Or add it to the project using `Add >  Existing Item > Add as Link`)
