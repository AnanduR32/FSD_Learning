from  flask import Flask, jsonify
import csv, json
from flask_cors import CORS, cross_origin

app = Flask(__name__)
cors = CORS(app, resources={r"/*": {"origins": "*"}})

data = []
with open('data/MOCK_DATA.csv', 'r') as file:
    csvReader = csv.DictReader(file)
    for row in csvReader:
        data.append(row)


@app.route('/getData')
def getData():
    global data
    return jsonify(data)

if __name__=="__main__":
    app.run(debug=True)