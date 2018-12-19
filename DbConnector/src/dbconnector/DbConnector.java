/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package dbconnector;

import java.sql.*;

/**
 *
 * @author Mohammed Ehab
 */
public class DbConnector {

    private static final String USERNAME = "root";
    private static final String PASSWORD = "";
    private static final String CONN_STRING = "jdbc:mysql://localhost:3306/bank";

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Connection conn = null;// new Connection(CONN_STRING,USERNAME,PASSWORD);
        try {
            conn = DriverManager.getConnection(CONN_STRING, USERNAME, PASSWORD);
            System.out.println("connected");
            Statement statement = (Statement) conn.createStatement();
//            String theQuery = "insert into 'table' bla bla bla";
//            statement.executeUpdate(theQuery);
            System.out.println(statement.executeQuery("select * from employees").getMetaData());

        } catch (SQLException e) {
            System.err.println("error " + e);
        }

    }
}
