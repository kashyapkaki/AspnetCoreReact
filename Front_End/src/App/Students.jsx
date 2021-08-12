import React, { useEffect, useState } from "react";
import { API_ROUTES } from "../AppConstants";
import Table from "react-bootstrap/Table";
import Button from "react-bootstrap/Button";
import {withRouter} from "react-router-dom";

function Students(props) {
  const [studentList, setStudentList] = useState(null);

  useEffect(() => {
    try {
      fetch(API_ROUTES.getStudents)
        .then((response) => response.json())
        .then((response) => setStudentList(response));
    } catch (error) {
      console.log(error);
    }
  }, []);

  return (
    <div>
      <h3>Students data from server:</h3>
      <Button
        variant="secondary"
        style={{ float: "right", margin: "20px" }}
        onClick={() => props.history.push("/addstudent")}
      >
        Add a Employee
      </Button>
      <Table striped bordered hover>
        <thead>
          <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Roll No</th>
            <th>Class</th>
            <th>Address</th>
            <th>Action</th>
          </tr>
        </thead>
        <tbody>
          {studentList &&
            studentList.map((student) => (
              <tr key={student.id}>
                <td>{student.id}</td>
                <td>{student.name}</td>
                <td>{student.rollNo}</td>
                <td>{student.class}</td>
                <td>{student.address}</td>
                <td>
                  <Button
                    onClick={() => this.props.history.push(`/updatestudent/${student.id}`)}
                  >
                    Update
                  </Button>
                  <Button variant="danger">Delete</Button>
                </td>
              </tr>
            ))}
        </tbody>
      </Table>
    </div>
  );
}

export default withRouter(Students);
