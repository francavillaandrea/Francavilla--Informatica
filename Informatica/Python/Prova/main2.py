from flask import Flask, request, jsonify
import time
import csv
import io
import socket

app = Flask(__name__)

@app.route('/data', methods=['POST'])
def receive_data():
    # ... (rest of your code remains exactly the same)

if __name__ == '__main__':
    try:
        # Try to resolve the hostname to an IP address
        host_ip = socket.gethostbyname('oleg.104')  # Resolve the hostname
        print(f"Resolved oleg.104 to IP: {host_ip}")  # Print the resolved IP for verification
        app.run(debug=True, host=host_ip, port=5000)  # Use the resolved IP
    except socket.gaierror:
        print("Error: Could not resolve hostname oleg.104.  Make sure it is configured correctly.")
        # You might want to exit the application here or use a fallback IP
        # For example:
        # app.run(debug=True, host='0.0.0.0', port=5000)  # Fallback to 0.0.0.0