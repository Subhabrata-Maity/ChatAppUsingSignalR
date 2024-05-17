import { useState } from "react";
import { Button, Form, Col, Row } from "react-bootstrap";

const WaitingRoom = ({ joinChatRoom }) => {
const [username, setUsername] = useState();
const [ChatRoom, setChatRoom] = useState();

return <Form onSubmit={ e=> {
    e.preventDefault();
    joinChatRoom(username, ChatRoom);
}}>
    <Row className="px-5 py-5">
        <Col sm={12}>
            <Form.Group>
                <Form.Control placeholder="Username" onChange={e => setUsername(e.target.value) }></Form.Control>

                <Form.Control placeholder="ChatRoom" onChange={e => setChatRoom(e.target.value) }></Form.Control>
            </Form.Group>
            <Col>
            <hr/>
            <Button variant="success" type="submit">Join</Button>
            </Col>
        </Col>
    </Row>
    </Form>
}
export default WaitingRoom;