import React, { useState } from 'react';
import Modal from 'react-modal';
import './Modals.css';
import './App.css';

const CorpoB = () => {
    const [modalIsOpen, setModalIsOpen] = useState(false);
    const [addPessoaModalIsOpen, setAddPessoaModalIsOpen] = useState(false);

    const openModal = () => {
        setModalIsOpen(true);
    };

    const closeModal = () => {
        setModalIsOpen(false);
    };

    const openAddPessoaModal = () => {
        setAddPessoaModalIsOpen(true);
    };

    const closeAddPessoaModal = () => {
        setAddPessoaModalIsOpen(false);
    };

    const modalStyle = {
        content: {
            backgroundColor: '#D9D9D9',
            width: '30%',
            height: '80%',
            margin: 'auto'
        }
    };

    return (
        <div className="imageBallonBox">
            <img
                className="imageBallon"
                src='.\botaoAdicionarFesta.PNG'
                alt="Balão de festa"
                onClick={openModal}
            />

            {/* Modal */}
            <Modal
                isOpen={modalIsOpen}
                onRequestClose={closeModal}
                contentLabel="Exemplo Modal"
            >
                <h3 className='modal-titulo'>Participantes</h3>
                <div className="uk-flex uk-flex-row uk-flex-between" id="navbar-modal">
                    <div className="uk-navbar">
                        <span className="uk-navbar-toggle-icon"></span>
                        <span className="uk-margin-small-left">Pessoa</span>
                    </div>

                    <div className="uk-navbar">
                        <span className="uk-navbar-toggle-icon"></span>
                        <span className="uk-margin-small-left">Convidado</span>
                    </div>

                    <div className="uk-navbar">
                        <span className="uk-navbar-toggle-icon"></span>
                        <span className="uk-margin-small-left">Confirmado</span>
                    </div>
                </div>

                <button className="modal-button" onClick={openAddPessoaModal}>
                    Adicionar Pessoa
                </button>
            </Modal>

            {/* Modal "Adicionar Pessoa" */}
            <Modal
                isOpen={addPessoaModalIsOpen}
                onRequestClose={closeAddPessoaModal}
                contentLabel="Adicionar Pessoa Modal"
                style={modalStyle}
            >
                <div className="uk-flex uk-flex-row uk-flex-between" id="navbar-modalP">
                    <div className="uk-navbar">
                        <span className="uk-navbar-toggle-icon"></span>
                        <span className="uk-margin-small-left">Buscar pessoas</span>
                    </div>

                    <div className="uk-navbar" id="input">
                        <span className="uk-margin-small-left">
                            <input type="text" />
                        </span>
                    </div>
                </div>
            </Modal>
        </div>
    );
};

export default CorpoB;
