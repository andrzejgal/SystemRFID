# SystemRFID has been created for small stores using Nedap security gates. Its main goal is alarm activation when unsold product passes 
the security gates line. The RFID system consits of following modules:
- asynchrous server receiving EPC read by gates,
- database containing list of sold and unsold products,
- software processing incoming EPCs to make proper querry to the database.
The list of sold and non sold products is updated by cash desk system.
The cash desk system must contain Nedap IdReader device for reading sold EPCs.
