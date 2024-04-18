# Car Props Asset Pack

This Asset pack adds a variety of car props to the game. They do not have any functionality and have to be used with caution.

# DISCLAIMER

Unofficial Custom Assets are highly experimental. They WILL crash your game at some point or throw errors. Create redundand copies of your savefiles and use at your own risk. There has not been a lot of testing done on custom assets, and I'm publishing this project to get feedback from the community.


## Getting Started:

1. Clone the repository OR Create a repository based on this ("Use this template", green button)
2. Open the repository with any IDE (Visual Studio, Rider)
   2A. If you are using an alternative Cities Skylines II installation path, enter it in the CustomAssetPack.csproj-file under "CustomManagedPath"
3. Put the assets you want to add into the "Resources/assets" folder in the solution explorer (subfolders allowed)
4. Edit the localization file "en-US.json" to include your assets. Otherwise, they will have missing localization
5. Click on the Build Symbol (Hammer) at the top to build your project. This will load the assets into your local mods folder

Publish:
To publish your mod you have to do the following steps:
1. Edit Properties/PublishConfiguration.xml
2. Edit DisplayName, ShortDescription, LongDescription and Tag
3. Replace the thumbnail.png file by the thumbnail for your Asset Pack
4. From within your IDE select the Run Configuration "Publish New Mod"