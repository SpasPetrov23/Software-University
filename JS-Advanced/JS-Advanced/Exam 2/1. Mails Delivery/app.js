function solve() {

    const recipientInputElement = document.getElementById('recipientName');
    const titleInputElement = document.getElementById('title');
    const messageInputElement = document.getElementById('message');
    const addBtnElement = document.getElementById('add');
    const resetBtnElement = document.getElementById('reset');
    const ulListElement = document.getElementById('list');
    const listOfMailsElement = document.querySelector('.list-mails');

    addBtnElement.addEventListener('click', addClickHandler);
    resetBtnElement.addEventListener('click', resetClickHandler);

    function addClickHandler(e) {
        e.preventDefault();

        let recipientName = recipientInputElement.value;
        let title = titleInputElement.value;
        let message = messageInputElement.value;

        if (!recipientName || !title || !message) {
            return;
        }

        let listElement = document.createElement('li');
        let nameRowElement = document.createElement('h4');
        let titleRowElement = document.createElement('h4');
        let messageRowElement = document.createElement('span');
        let actionRowElement = document.createElement('div');
        let sendBtnElement = document.createElement('button');
        let deleteBtnElement = document.createElement('button');

        listElement.setAttribute('id', 'list-action');
        titleRowElement.textContent = `Title: ${title}`;
        nameRowElement.textContent = `Recipient Name: ${recipientName}`;
        messageRowElement.textContent = message; //?
        actionRowElement.setAttribute('id', 'list-action');
        sendBtnElement.setAttribute('type', 'submit');
        sendBtnElement.setAttribute('id', 'send');
        sendBtnElement.textContent = 'Send';
        deleteBtnElement.setAttribute('type', 'submit');
        deleteBtnElement.setAttribute('id', 'delete');
        deleteBtnElement.textContent = 'Delete';
        deleteBtnElement.addEventListener('click', (e) => {
            e.preventDefault();
            deleteButtonActions();

            listElement.remove();
        });
        actionRowElement.appendChild(sendBtnElement);
        actionRowElement.appendChild(deleteBtnElement);

        listElement.appendChild(titleRowElement);
        listElement.appendChild(nameRowElement);
        listElement.appendChild(messageRowElement);
        listElement.appendChild(actionRowElement);

        ulListElement.appendChild(listElement);

        titleInputElement.value = '';
        recipientInputElement.value = '';
        messageInputElement.value = '';

        sendBtnElement.addEventListener('click', (e) => {
            e.preventDefault();

            let sentMailsUlElement = document.querySelector('.sent-list');
            let sentMailsListElement = document.createElement('li');
            let sentMailSenderCol = document.createElement('span');
            let sentMailTitleCol = document.createElement('span');
            let sentMailBtnRow = document.createElement('div');
            let sentMailDeleteBtn = document.createElement('button');

            sentMailSenderCol.textContent = `To: ${recipientName}`;
            sentMailTitleCol.textContent = `Title: ${title}`;
            sentMailBtnRow.classList.add('btn');
            sentMailDeleteBtn.setAttribute('type', 'submit');
            sentMailDeleteBtn.classList.add('delete');
            sentMailDeleteBtn.textContent = 'Delete';
            sentMailBtnRow.appendChild(sentMailDeleteBtn);
            sentMailDeleteBtn.addEventListener('click', (e) => {
                e.preventDefault();
                deleteButtonActions();

                sentMailsListElement.remove();
            });

            listElement.remove();

            sentMailsListElement.appendChild(sentMailSenderCol);
            sentMailsListElement.appendChild(sentMailTitleCol);
            sentMailsListElement.appendChild(sentMailBtnRow);

            sentMailsUlElement.appendChild(sentMailsListElement);
        });

        function deleteButtonActions() {
            let deletedMailsUlElement = document.querySelector('.delete-list');
            let deletedMailsListElement = document.createElement('li');
            let deletedMailSenderCol = document.createElement('span');
            let deletedMailTitleCol = document.createElement('span');

            deletedMailSenderCol.textContent = `To: ${recipientName}`;
            deletedMailTitleCol.textContent = `Title: ${title}`;

            deletedMailsListElement.appendChild(deletedMailSenderCol);
            deletedMailsListElement.appendChild(deletedMailTitleCol);
            deletedMailsUlElement.appendChild(deletedMailsListElement);
        }
    }

    function resetClickHandler(e) {
        e.preventDefault();

        titleInputElement.value = '';
        recipientInputElement.value = '';
        messageInputElement.value = '';
    }
}
solve()