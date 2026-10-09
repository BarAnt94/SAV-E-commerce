# SAV E-commerce

Avant d'installer le projet, assurez-vous de disposer des éléments suivants :

Windows 10 ou Windows 11.
Visual Studio 2022 avec la charge de travail Développement d'applications de bureau .NET.
Le SDK .NET 8.
Git, pour récupérer le dépôt.

Pour vérifier que le SDK .NET est installé, ouvrez un terminal et exécutez :

dotnet --list-sdks

Vérifiez que la liste contient une version 8.0.x.

Installation du projet
Cloner le dépôt GitHub

Ouvrez un terminal à l'emplacement où vous souhaitez installer le projet.

git clone URL_DU_DEPOT

Remplacez URL_DU_DEPOT par l'URL réelle du dépôt GitHub.

Accédez ensuite au dossier du projet :

cd NOM_DU_PROJET
Ouvrir le projet

Ouvrez le fichier solution .sln dans Visual Studio.

Si le dépôt ne contient pas de fichier solution, ouvrez directement le fichier projet .csproj.

Vérifiez que le projet cible bien .NET 8 et que la plateforme Windows est correctement configurée.

3. Restaurer les dépendances

Depuis le dossier contenant le fichier .csproj, exécutez :

dotnet restore

Le package NuGet Microsoft.Data.Sqlite doit être référencé dans le projet. S'il figure déjà dans le fichier .csproj, la restauration le récupère automatiquement.

Si ce package n'est pas encore référencé, ajoutez-le avec :

dotnet add package Microsoft.Data.Sqlite

Utilisez une version du package compatible avec votre projet.

Démarrage de l'application
Méthode 1 : avec Visual Studio
Ouvrez la solution ou le projet dans Visual Studio.
Définissez le projet WinForms comme projet de démarrage.
Vérifiez que la configuration Debug et la plateforme adaptée sont sélectionnées.
Appuyez sur F5 pour démarrer avec le débogueur, ou sur Ctrl + F5 pour démarrer sans débogage.

La fenêtre principale de l'application devrait s'ouvrir si le projet est correctement configuré.

Méthode 2 : avec le terminal

Placez-vous dans le dossier contenant le fichier .csproj, puis exécutez :

dotnet run

Pour compiler le projet sans le démarrer :

dotnet build

Pour générer une version compilée en mode Release :

dotnet publish -c Release

La publication peut nécessiter des paramètres supplémentaires selon la configuration du projet et la plateforme cible.

Dépannage
Le SDK .NET 8 est introuvable

Vérifiez la version installée avec :

dotnet --list-sdks

Installez le SDK .NET 8 si nécessaire.

Le package Microsoft.Data.Sqlite est introuvable

Restaurez les dépendances :

dotnet restore

Vérifiez également la présence de Microsoft.Data.Sqlite dans le fichier .csproj.

La base de données ne s'ouvre pas

Vérifiez le chemin du fichier SQLite, les droits d'accès et l'existence du dossier parent.

L'application ne démarre pas

Exécutez :

dotnet build

Corrigez les erreurs de compilation affichées, puis relancez l'application.

La documentation du projet se trouve dans le fichier du même nom où il y a les diagrammes de séquence, diagramme de classe, diagramme de cas d'utilisation et diagramme de Gantt.
Il y a tous les détails du cahier des charges qui va avec.
