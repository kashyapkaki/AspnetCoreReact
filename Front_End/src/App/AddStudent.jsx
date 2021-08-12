import React, { Component } from "react";
import { Container, Form, Row, Col, Button } from "react-bootstrap";

class AddStudent extends Component {
  render() {
    return (
      <Container>
        <h1>Add Student</h1>
        <Form>
          <Form.Row>
            <Col>
              <Form.Control placeholder="Enter Name" />
            </Col>
            <Col>
              <Form.Control placeholder="Enter Roll No" />
            </Col>
            <Col>
              <Form.Control placeholder="Enter Class" />
            </Col>
            <Col>
              <Form.Control placeholder="Enter Address" />
            </Col>
          </Form.Row>
          <Button style={{ margin: "30px", float: "right" }}>
            Add Employee
          </Button>
        </Form>
      </Container>
    );
  }
}

export default AddStudent;
