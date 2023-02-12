# Aufgabe
Du sollst eine Klasse namens "DatabaseLogger" implementieren, welche die Schnittstelle ILogger implementiert. Die Klasse soll Nachrichten in eine SQLite-Datenbank protokollieren.

1. Erstelle einen Konstruktor, der eine Verbindungszeichenfolge als Argument annimmt und in einer privaten Membervariable speichert.
2. Implementiere die Log-Methode aus der ILogger-Schnittstelle. Die Methode soll die Nachricht und das LogLevel in die SQLite-Datenbank einfügen. Die Tabelle "Log" in der SQLite-Datenbank enthält vier Spalten: 
    - "Id": Eine eindeutige Identifikationsnummer für jeden Eintrag im Log. Diese Spalte ist als Primärschlüssel konfiguriert und wird automatisch von SQLite generiert, wenn ein neuer Eintrag hinzugefügt wird.
    - "Date": Das Datum und die Uhrzeit, zu der die Nachricht protokolliert wurde. Die Spalte enthält einen Zeitstempelwert und darf nicht leer sein.
    - "Level": Das LogLevel der Nachricht, z.B. Error, Warning oder Info. Die Spalte enthält einen Zeichenfolgenwert mit einer festen Länge von 20 Zeichen und darf nicht leer sein.
    - "Message": Der eigentliche Inhalt der Nachricht. Die Spalte enthält einen Textwert und darf nicht leer sein.

    Mit jedem Aufruf der Log-Methode in der Klasse "DatabaseLogger" wird ein neuer Eintrag in die Tabelle "Log" eingefügt, der das Datum, das LogLevel und den Inhalt der Nachricht enthält. Du kannst später auf diese Daten zugreifen, um z.B. statistische Auswertungen durchzuführen oder Fehler im System zu diagnostizieren.
Stelle sicher, dass die Tabelle "Log" erstellt wird, wenn sie noch nicht existiert.
3. Verwende in der Log-Methode einen using-Block, um eine Verbindung zur Datenbank herzustellen und die Befehle auszuführen.

4. Überprüfe deine Implementierung, indem du eine Testanwendung erstellst, die die Klasse DatabaseLogger verwendet, um Nachrichten in die Datenbank zu protokollieren:
```
var databaseLogger = new DatabaseLogger("Data Source = log.db");
databaseLogger.Log("Application started", LogLevel.Info);
```
Hinweis: Verwende das NuGet-Paket Microsoft.Data.Sqlite für die Verwendung von SQLite in C#.
