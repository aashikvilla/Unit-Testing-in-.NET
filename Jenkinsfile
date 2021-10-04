def workspace ='Unit-Testing-in-.NET'
def solutionName='Unit-Testing-in-.NET'

def pathToProject='app\\app'

def pathToUnitTestProject='app-test\\app-test'

def publishConfiguration='debug'
def framework='netstandard2.0'

def zipFolderName='app'


pipeline {
    agent { node { label 'WINAGENT02' } }

    stages {
        
        stage('Restore') {
            steps {
                echo 'Restore..  dotnet restore  '
                  bat "dotnet restore ${solutionName}.sln"
            }
        }
        stage('Build') {
            when {
                branch 'master'
            }
            steps {
                echo 'Compile..  dotnet build  '
                bat "dotnet build ${pathToProject}.csproj"
     
            }
        }
        stage('Unit Test') {
            steps {
                echo 'Testing.. dotnet test  '
                  bat "dotnet test ${pathToUnitTestProject}.csproj"
            }
        }
        stage('Compile & Zip') {
            steps {
                echo 'Compile..  dotnet build  '
                bat "dotnet build ${pathToProject}.csproj /T:Publish /p:configuration=${publishConfiguration} /p:framework=${framework} /p:WebPublishMethod=Package /p:PackageAsSingleFile=true /p:DesktopBuildPackageLocation=\"bin\\debug\\webpackage\\${zipFolderName}\""
     
            }
        }
        
         
        stage('Deploy(Dev)') {
            steps {
                echo 'Deploying in Dev....'
            }
        }
    }
}
