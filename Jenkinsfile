pipeline {
    agent anyagent { node { label 'WINAGENT02' } }

    stages {
        stage('Build') {
            steps {
                echo 'Building..  dotnet build  '
                bat 'dotnet build'
            }
        }
        stage('Unit Test') {
            steps {
                echo 'Testing.. dotnet test  '
                bat 'dotnet test'
            }
        }
        stage('Deploy(Dev)') {
            steps {
                echo 'Deploying in Dev....'
            }
        }
    }
}
