import datetime

def log_vending_activity(item_name):
    # Define the log file path
    log_file_path = 'C:\\Users\\chris\\college\\VendingMachine\\vending_log.txt'
    
    # Get the current timestamp
    timestamp = datetime.datetime.now().strftime('%Y-%m-%d %H:%M:%S')
    
    # Create the log entry
    log_entry = f"{timestamp} - Vended: {item_name}\n"
    
    # Append the log entry to the log file
    with open(log_file_path, 'a') as log_file:
        log_file.write(log_entry)

# Example usage:
# log_vending_activity('Cheetos Cheese Flavor')
