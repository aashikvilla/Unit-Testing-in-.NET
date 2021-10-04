def workspace ='Unit-Testing-in-.NET-Core'
def solutionName='Testing in .NET Core'

def pathToProject='app\\app'

def pathToUnitTestProject='app-test\\app-test’

def publishConfiguration='debug'
def framework='netstandard2.0'

def zipFolderName='app'


pipeline {
    agent { node { label 'WINAGENT02' } }

    stages {
        
        stage('Restore') {
            steps {
                echo 'Restore..  dotnet restore  '
                  bat "dotnet restore ${workspace}\\${solutionName}.sln"
            }
        }
        stage('Compile') {
            steps {
                echo 'Compile..  dotnet build  '
                bat "dotnet build ${workspace}\\${pathToProject}.csproj /T:Publish /p:configuration=${publishConfiguration} /p:framework=${framework} /p:WebPublishMethod=Package /p:PackageAsSingleFile=true /p:DesktopBuildPackageLocation=\"bin\\debug\\webpackage\\${zipFolderName}\""
     
            }
        }
        stage('Unit Test') {
            steps {
                echo 'Testing.. dotnet test  '
                  bat "dotnet test ${workspace}\\${pathToUnitTestProject}.csproj"
            }
        }
         
        stage('Deploy(Dev)') {
            steps {
                echo 'Deploying in Dev....'
            }
        }
    }
}
