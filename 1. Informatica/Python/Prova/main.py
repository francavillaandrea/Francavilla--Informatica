from flask import Flask, request, jsonify
import time
import json  # For handling JSON data (better than relying on Flask's implicit JSON handling)

app = Flask(__name__)

@app.route('/data', methods=['POST'])
def receive_data():
    try:
        data = request.get_json()  # Get the JSON data from the request

        if data:
            timestamp = time.strftime("%Y-%m-%d %H:%M:%S")  # Add timestamp
            data['timestamp'] = timestamp

            print("Received data:", data)  # Print the received data (for debugging)
            # --- Process the data here ---
            # Example: Store in a file, database, etc.
            # For demonstration, we'll just save it to a JSON file:
            try:
                with open("sensor_data.json", "a") as f:  # Append to file
                    f.write(json.dumps(data) + "\n")  # Write each data point as a separate JSON line
            except Exception as e:
                print(f"Error writing to file: {e}")
                return jsonify({"status": "error", "message": "Error saving data"}), 500  # Internal Server Error

            return jsonify({"status": "success", "message": "Data received and processed"}), 200  # OK

        else:
            return jsonify({"status": "error", "message": "No data received"}), 400  # Bad Request

    except json.JSONDecodeError:
        return jsonify({"status": "error", "message": "Invalid JSON data"}), 400  # Bad Request
    except Exception as e: # Catch any other exceptions during processing
        print(f"An unexpected error occurred: {e}")
        return jsonify({"status": "error", "message": "An unexpected error occurred"}), 500  # Internal Server Error


if __name__ == '__main__':
    app.run(debug=True, host='0.0.0.0', port=5000)  # host='0.0.0.0' makes it accessible on your network