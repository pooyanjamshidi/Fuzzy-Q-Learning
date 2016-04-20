function stat=nqlearn(stat)
%% a neuron coupled with q-learning
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


global LAMBDA

% Finding the Max factor in the current state but here through vector not Q
% values as in traditional q-learning procedure

q_next=max(value_finder(stat.current_state,1,stat.vector),value_finder(stat.current_state,2,stat.vector));

% incrementing the learning iteration
stat.iter=stat.iter+1;
%% Setting the step-size to determine how fast learning takes place: learning rate

%learn_rate=1/(stat.iter);

%learn_rate=log(stat.iter+1)/(stat.iter+1);

learn_rate=0.5*300/(300+stat.iter);


%% Value iteration update rule
% Q_old
q=value_finder(stat.old_state,stat.old_action,stat.vector);

% Q_new
q=q*(1-learn_rate)+(learn_rate*(stat.rimm+(LAMBDA*q_next)));

% update the vector through neural network update
stat.vector=update_net(q,stat.old_action,stat.old_state,stat.vector);

% update Q
stat.Q(stat.old_state,stat.old_action)=q;
