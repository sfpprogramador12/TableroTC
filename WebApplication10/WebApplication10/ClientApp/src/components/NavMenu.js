import React from 'react';
import { Link } from 'react-router-dom';
import { Glyphicon, Nav, Navbar, NavItem } from 'react-bootstrap';
import { LinkContainer } from 'react-router-bootstrap';
import './NavMenu.css';

export default props => (
  <Navbar inverse fixedTop fluid collapseOnSelect>
    <Navbar.Header>
      <Navbar.Brand>
                <Link to={'/'}>Tablero de Control</Link>
                <p className="version">Vers. 3.11</p>
      </Navbar.Brand>
      <Navbar.Toggle />
    </Navbar.Header>
        <Navbar.Collapse>
            <Nav>
                <LinkContainer to={'/'} exact>
                  <NavItem>
                    <Glyphicon glyph='home' /> Inicio
                  </NavItem>
                </LinkContainer>


                <LinkContainer to={'/Indicador/777382'}>
                  <NavItem>
                    <Glyphicon glyph='th-list' /> MIR
                  </NavItem>
                </LinkContainer>


                <LinkContainer to={'/Indicador/807167'}>
                  <NavItem>
                    <Glyphicon glyph='th-list' /> PGCM
                  </NavItem>
                </LinkContainer>


                <LinkContainer to={'/Indicador/7173'}>
                  <NavItem>
                    <Glyphicon glyph='th-list' /> GI
                  </NavItem>
               </LinkContainer>


                <LinkContainer to={'/Indicador/806973'}>
                  <NavItem>
                    <Glyphicon glyph='th-list' /> PEI
                  </NavItem>
               </LinkContainer>

      </Nav>
    </Navbar.Collapse>
  </Navbar>
);
