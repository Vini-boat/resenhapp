import React from 'react';


const Navbar = () => {
    return (
        <div className="uk-container">
            <div className="uk-navbar">
                <div className="uk-navbar-left">
                    <a className="uk-navbar-toggle" href="#">
                        <span uk-navbar-toggle-icon></span> <span className="uk-margin-small-left">Menu</span>
                    </a>
                </div>

                <div className="uk-navbar-center">
                    <span uk-navbar-toggle-icon></span> <span className="uk-margin-small-left">Suas festas!</span>
                </div>

                <div className="uk-navbar-right">
                    <img className="image" src='.\giaretta.PNG' alt="léo Stronda" />
                </div>
            </div>


        </div>
    );
}


export default Navbar;