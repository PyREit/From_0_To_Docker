from flask import Flask
app = Flask(__name__)

@app.route('/')
def hello_world():
    return '''
<html>
    <head>
        <title>From 0 to Docker - #3</title>
    </head>
    <body>
        <h1>Flask Dockerized!</h1>
    </body>
</html>''' 

if __name__ == '__main__':
    app.run(debug=True,host='0.0.0.0')